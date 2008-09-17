-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    state TEXT NOT NULL DEFAULT 'new',
    ratio REAL,
    weight REAL,
    label TEXT
);

CREATE INDEX IF NOT EXISTS idx_layout_items_weight ON layout_items (weight);

INSERT INTO layout_items (state, ratio, weight, label) VALUES ('strict', 34.28, 80.83, 'fallback');
INSERT INTO layout_items (state, ratio, weight, label) VALUES ('fallback', 51.07, 10.89, 'edge');
INSERT INTO layout_items (state, ratio, weight, label) VALUES ('staging', 26.68, 14.81, 'strict');
