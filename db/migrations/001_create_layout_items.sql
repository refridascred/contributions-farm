-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    active INTEGER NOT NULL DEFAULT 1,
    label TEXT,
    score REAL NOT NULL DEFAULT 0,
    state TEXT NOT NULL DEFAULT 'new',
    token TEXT
);

CREATE INDEX IF NOT EXISTS idx_layout_items_score ON layout_items (score);

INSERT INTO layout_items (active, label, score, state, token) VALUES (5, 'strict', 62.83, 'strict', 'primary');
INSERT INTO layout_items (active, label, score, state, token) VALUES (1, 'blue', 47.08, 'eu-west', 'standard');
