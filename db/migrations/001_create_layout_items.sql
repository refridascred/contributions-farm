-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    weight REAL,
    state TEXT NOT NULL DEFAULT 'new',
    label TEXT,
    region TEXT
);

CREATE INDEX IF NOT EXISTS idx_layout_items_region ON layout_items (region);

INSERT INTO layout_items (weight, state, label, region) VALUES (36.87, 'primary', 'green', 'eu-west');
INSERT INTO layout_items (weight, state, label, region) VALUES (67.71, 'strict', 'fallback', 'staging');
INSERT INTO layout_items (weight, state, label, region) VALUES (12.2, 'edge', 'local', 'eu-west');
