-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    rank INTEGER,
    label TEXT,
    state TEXT NOT NULL DEFAULT 'new',
    count INTEGER NOT NULL DEFAULT 0,
    score REAL NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_layout_items_state ON layout_items (state);

INSERT INTO layout_items (rank, label, state, count, score) VALUES (60, 'legacy', 'cached', 12, 1.51);
INSERT INTO layout_items (rank, label, state, count, score) VALUES (3, 'stable', 'eu-west', 62, 10.27);
INSERT INTO layout_items (rank, label, state, count, score) VALUES (0, 'eu-west', 'staging', 97, 86.66);
