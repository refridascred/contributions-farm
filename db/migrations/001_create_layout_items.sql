-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    region TEXT,
    level INTEGER,
    created_at TIMESTAMP,
    weight REAL
);

CREATE INDEX IF NOT EXISTS idx_layout_items_created_at ON layout_items (created_at);

INSERT INTO layout_items (region, level, weight) VALUES ('cached', 39, 67.87);
INSERT INTO layout_items (region, level, weight) VALUES ('local', 43, 2.02);
INSERT INTO layout_items (region, level, weight) VALUES ('staging', 41, 8.55);
