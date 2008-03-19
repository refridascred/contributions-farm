-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    label TEXT,
    created_at TIMESTAMP,
    region TEXT,
    weight REAL
);

CREATE INDEX IF NOT EXISTS idx_layout_items_weight ON layout_items (weight);

INSERT INTO layout_items (label, region, weight) VALUES ('staging', 'standard', 52.92);
INSERT INTO layout_items (label, region, weight) VALUES ('local', 'blue', 45.65);
INSERT INTO layout_items (label, region, weight) VALUES ('latest', 'green', 20.02);
