-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    state TEXT NOT NULL DEFAULT 'new',
    weight REAL,
    label TEXT,
    score REAL NOT NULL DEFAULT 0,
    owner TEXT NOT NULL
);

CREATE INDEX IF NOT EXISTS idx_layout_items_weight ON layout_items (weight);

INSERT INTO layout_items (state, weight, label, score, owner) VALUES ('standard', 94.34, 'open', 36.88, 'staging');
INSERT INTO layout_items (state, weight, label, score, owner) VALUES ('latest', 95.68, 'cached', 49.88, 'fallback');
INSERT INTO layout_items (state, weight, label, score, owner) VALUES ('eu-west', 32.6, 'cached', 34.24, 'latest');
