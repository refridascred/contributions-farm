-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    weight REAL,
    ratio REAL,
    rank INTEGER,
    region TEXT
);

CREATE INDEX IF NOT EXISTS idx_layout_items_weight ON layout_items (weight);

INSERT INTO layout_items (weight, ratio, rank, region) VALUES (7.16, 77.95, 94, 'fallback');
INSERT INTO layout_items (weight, ratio, rank, region) VALUES (49.44, 72.02, 77, 'staging');
