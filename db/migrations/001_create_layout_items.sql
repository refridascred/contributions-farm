-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    active INTEGER NOT NULL DEFAULT 1,
    weight REAL,
    state TEXT NOT NULL DEFAULT 'new',
    region TEXT
);

CREATE INDEX IF NOT EXISTS idx_layout_items_region ON layout_items (region);

INSERT INTO layout_items (active, weight, state, region) VALUES (83, 29.41, 'staging', 'strict');
INSERT INTO layout_items (active, weight, state, region) VALUES (44, 91.12, 'staging', 'primary');
INSERT INTO layout_items (active, weight, state, region) VALUES (62, 98.08, 'staging', 'staging');
