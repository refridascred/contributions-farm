-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    created_at TIMESTAMP,
    token TEXT,
    count INTEGER NOT NULL DEFAULT 0,
    state TEXT NOT NULL DEFAULT 'new',
    rank INTEGER
);

CREATE INDEX IF NOT EXISTS idx_layout_items_rank ON layout_items (rank);

INSERT INTO layout_items (token, count, state, rank) VALUES ('primary', 25, 'fallback', 50);
INSERT INTO layout_items (token, count, state, rank) VALUES ('fallback', 40, 'cached', 66);
INSERT INTO layout_items (token, count, state, rank) VALUES ('eu-west', 96, 'cached', 78);
