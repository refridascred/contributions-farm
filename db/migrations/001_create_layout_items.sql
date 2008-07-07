-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    region TEXT,
    weight REAL,
    count INTEGER NOT NULL DEFAULT 0,
    level INTEGER,
    created_at TIMESTAMP
);

CREATE INDEX IF NOT EXISTS idx_layout_items_created_at ON layout_items (created_at);

INSERT INTO layout_items (region, weight, count, level) VALUES ('eu-west', 0.91, 80, 60);
INSERT INTO layout_items (region, weight, count, level) VALUES ('standard', 83.59, 83, 85);
INSERT INTO layout_items (region, weight, count, level) VALUES ('edge', 52.06, 86, 6);
