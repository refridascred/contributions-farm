-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    count INTEGER NOT NULL DEFAULT 0,
    score REAL NOT NULL DEFAULT 0,
    state TEXT NOT NULL DEFAULT 'new',
    label TEXT,
    rank INTEGER
);

CREATE INDEX IF NOT EXISTS idx_layout_items_state ON layout_items (state);

INSERT INTO layout_items (count, score, state, label, rank) VALUES (36, 89.19, 'cached', 'local', 24);
INSERT INTO layout_items (count, score, state, label, rank) VALUES (23, 93.3, 'green', 'primary', 60);
