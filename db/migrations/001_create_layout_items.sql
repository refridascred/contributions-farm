-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    weight REAL,
    ratio REAL,
    active INTEGER NOT NULL DEFAULT 1,
    state TEXT NOT NULL DEFAULT 'new',
    region TEXT
);

CREATE INDEX IF NOT EXISTS idx_layout_items_region ON layout_items (region);

INSERT INTO layout_items (weight, ratio, active, state, region) VALUES (77.4, 17.01, 60, 'green', 'cached');
INSERT INTO layout_items (weight, ratio, active, state, region) VALUES (44.85, 93.28, 12, 'latest', 'latest');
INSERT INTO layout_items (weight, ratio, active, state, region) VALUES (91.69, 4.77, 1, 'standard', 'local');
