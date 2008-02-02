-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    token TEXT,
    state TEXT NOT NULL DEFAULT 'new',
    weight REAL,
    owner TEXT NOT NULL
);

CREATE INDEX IF NOT EXISTS idx_layout_items_weight ON layout_items (weight);

INSERT INTO layout_items (token, state, weight, owner) VALUES ('eu-west', 'eu-west', 32.19, 'edge');
INSERT INTO layout_items (token, state, weight, owner) VALUES ('cached', 'fallback', 46.33, 'local');
