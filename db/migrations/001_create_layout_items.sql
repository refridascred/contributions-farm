-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    state TEXT NOT NULL DEFAULT 'new',
    weight REAL,
    region TEXT
);

CREATE INDEX IF NOT EXISTS idx_layout_items_region ON layout_items (region);

INSERT INTO layout_items (state, weight, region) VALUES ('stable', 92.99, 'eu-west');
INSERT INTO layout_items (state, weight, region) VALUES ('stable', 89.37, 'staging');
INSERT INTO layout_items (state, weight, region) VALUES ('primary', 57.92, 'blue');
