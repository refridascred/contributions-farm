-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    region TEXT,
    weight REAL,
    created_at TIMESTAMP,
    ratio REAL,
    active INTEGER NOT NULL DEFAULT 1
);

CREATE INDEX IF NOT EXISTS idx_layout_items_weight ON layout_items (weight);

INSERT INTO layout_items (region, weight, ratio, active) VALUES ('green', 10.99, 6.67, 57);
INSERT INTO layout_items (region, weight, ratio, active) VALUES ('green', 19.53, 30.21, 77);
