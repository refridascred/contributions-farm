-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    weight REAL,
    ratio REAL,
    state TEXT NOT NULL DEFAULT 'new',
    label TEXT
);

CREATE INDEX IF NOT EXISTS idx_layout_items_weight ON layout_items (weight);

INSERT INTO layout_items (weight, ratio, state, label) VALUES (88.35, 2.93, 'legacy', 'standard');
INSERT INTO layout_items (weight, ratio, state, label) VALUES (61.08, 66.73, 'standard', 'staging');
INSERT INTO layout_items (weight, ratio, state, label) VALUES (34.37, 64.05, 'cached', 'staging');
