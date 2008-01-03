-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    created_at TIMESTAMP,
    weight REAL,
    label TEXT,
    score REAL NOT NULL DEFAULT 0,
    region TEXT
);

CREATE INDEX IF NOT EXISTS idx_layout_items_region ON layout_items (region);

INSERT INTO layout_items (weight, label, score, region) VALUES (28.13, 'open', 27.9, 'primary');
INSERT INTO layout_items (weight, label, score, region) VALUES (18.52, 'standard', 8.14, 'blue');
INSERT INTO layout_items (weight, label, score, region) VALUES (60.35, 'primary', 63.74, 'latest');
