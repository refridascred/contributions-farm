-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    ratio REAL,
    weight REAL,
    label TEXT,
    token TEXT
);

CREATE INDEX IF NOT EXISTS idx_layout_items_weight ON layout_items (weight);

INSERT INTO layout_items (ratio, weight, label, token) VALUES (35.24, 5.95, 'staging', 'primary');
INSERT INTO layout_items (ratio, weight, label, token) VALUES (57.13, 63.9, 'blue', 'latest');
INSERT INTO layout_items (ratio, weight, label, token) VALUES (64.14, 90.0, 'stable', 'cached');
