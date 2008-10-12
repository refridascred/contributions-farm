-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    owner TEXT NOT NULL,
    rank INTEGER,
    score REAL NOT NULL DEFAULT 0,
    label TEXT,
    count INTEGER NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_layout_items_rank ON layout_items (rank);

INSERT INTO layout_items (owner, rank, score, label, count) VALUES ('local', 6, 35.69, 'eu-west', 42);
INSERT INTO layout_items (owner, rank, score, label, count) VALUES ('eu-west', 43, 48.63, 'cached', 69);
INSERT INTO layout_items (owner, rank, score, label, count) VALUES ('eu-west', 23, 72.9, 'stable', 15);
