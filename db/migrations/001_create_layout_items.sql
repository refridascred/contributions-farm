-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    active INTEGER NOT NULL DEFAULT 1,
    label TEXT,
    rank INTEGER,
    score REAL NOT NULL DEFAULT 0,
    ratio REAL
);

CREATE INDEX IF NOT EXISTS idx_layout_items_label ON layout_items (label);

INSERT INTO layout_items (active, label, rank, score, ratio) VALUES (78, 'latest', 45, 54.51, 31.59);
INSERT INTO layout_items (active, label, rank, score, ratio) VALUES (2, 'blue', 12, 87.21, 49.27);
