-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    score REAL NOT NULL DEFAULT 0,
    state TEXT NOT NULL DEFAULT 'new',
    rank INTEGER,
    count INTEGER NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_layout_items_score ON layout_items (score);

INSERT INTO layout_items (score, state, rank, count) VALUES (78.65, 'local', 64, 72);
INSERT INTO layout_items (score, state, rank, count) VALUES (74.33, 'cached', 13, 68);
INSERT INTO layout_items (score, state, rank, count) VALUES (44.89, 'legacy', 67, 28);
