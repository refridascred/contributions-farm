-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    active INTEGER NOT NULL DEFAULT 1,
    rank INTEGER,
    token TEXT,
    label TEXT,
    score REAL NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_layout_items_score ON layout_items (score);

INSERT INTO layout_items (active, rank, token, label, score) VALUES (45, 17, 'edge', 'strict', 44.42);
INSERT INTO layout_items (active, rank, token, label, score) VALUES (37, 68, 'staging', 'open', 8.49);
INSERT INTO layout_items (active, rank, token, label, score) VALUES (86, 51, 'standard', 'stable', 91.6);
