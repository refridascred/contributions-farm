-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    score REAL NOT NULL DEFAULT 0,
    state TEXT NOT NULL DEFAULT 'new',
    label TEXT,
    weight REAL,
    owner TEXT NOT NULL
);

CREATE INDEX IF NOT EXISTS idx_layout_items_weight ON layout_items (weight);

INSERT INTO layout_items (score, state, label, weight, owner) VALUES (37.69, 'eu-west', 'open', 27.69, 'edge');
INSERT INTO layout_items (score, state, label, weight, owner) VALUES (11.05, 'standard', 'cached', 55.44, 'strict');
INSERT INTO layout_items (score, state, label, weight, owner) VALUES (93.4, 'cached', 'fallback', 29.6, 'blue');
