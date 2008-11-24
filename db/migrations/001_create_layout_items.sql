-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    label TEXT,
    score REAL NOT NULL DEFAULT 0,
    count INTEGER NOT NULL DEFAULT 0,
    rank INTEGER,
    owner TEXT NOT NULL
);

CREATE INDEX IF NOT EXISTS idx_layout_items_label ON layout_items (label);

INSERT INTO layout_items (label, score, count, rank, owner) VALUES ('green', 7.72, 35, 93, 'eu-west');
INSERT INTO layout_items (label, score, count, rank, owner) VALUES ('staging', 97.53, 80, 18, 'fallback');
INSERT INTO layout_items (label, score, count, rank, owner) VALUES ('fallback', 79.07, 28, 37, 'strict');
