-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    state TEXT NOT NULL DEFAULT 'new',
    score REAL NOT NULL DEFAULT 0,
    created_at TIMESTAMP,
    rank INTEGER
);

CREATE INDEX IF NOT EXISTS idx_layout_items_rank ON layout_items (rank);

INSERT INTO layout_items (state, score, rank) VALUES ('local', 95.06, 58);
INSERT INTO layout_items (state, score, rank) VALUES ('green', 5.38, 54);
INSERT INTO layout_items (state, score, rank) VALUES ('eu-west', 47.61, 38);
