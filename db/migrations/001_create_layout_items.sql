-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    region TEXT,
    created_at TIMESTAMP,
    level INTEGER,
    weight REAL
);

CREATE INDEX IF NOT EXISTS idx_layout_items_created_at ON layout_items (created_at);

INSERT INTO layout_items (region, level, weight) VALUES ('stable', 63, 95.16);
INSERT INTO layout_items (region, level, weight) VALUES ('standard', 4, 29.8);
