-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    state TEXT NOT NULL DEFAULT 'new',
    owner TEXT NOT NULL,
    label TEXT,
    score REAL NOT NULL DEFAULT 0,
    weight REAL
);

CREATE INDEX IF NOT EXISTS idx_layout_items_weight ON layout_items (weight);

INSERT INTO layout_items (state, owner, label, score, weight) VALUES ('green', 'open', 'fallback', 88.33, 55.12);
INSERT INTO layout_items (state, owner, label, score, weight) VALUES ('edge', 'local', 'stable', 16.1, 7.54);
