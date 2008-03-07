-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    label TEXT,
    weight REAL,
    region TEXT
);

CREATE INDEX IF NOT EXISTS idx_layout_items_weight ON layout_items (weight);

INSERT INTO layout_items (label, weight, region) VALUES ('latest', 14.85, 'fallback');
INSERT INTO layout_items (label, weight, region) VALUES ('fallback', 62.77, 'staging');
