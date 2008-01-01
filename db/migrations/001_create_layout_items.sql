-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    label TEXT,
    state TEXT NOT NULL DEFAULT 'new',
    count INTEGER NOT NULL DEFAULT 0,
    score REAL NOT NULL DEFAULT 0,
    rank INTEGER
);

CREATE INDEX IF NOT EXISTS idx_layout_items_score ON layout_items (score);

INSERT INTO layout_items (label, state, count, score, rank) VALUES ('stable', 'eu-west', 36, 55.11, 28);
INSERT INTO layout_items (label, state, count, score, rank) VALUES ('strict', 'local', 8, 41.75, 75);
