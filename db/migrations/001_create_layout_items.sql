-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    label TEXT,
    ratio REAL,
    owner TEXT NOT NULL,
    score REAL NOT NULL DEFAULT 0,
    rank INTEGER
);

CREATE INDEX IF NOT EXISTS idx_layout_items_score ON layout_items (score);

INSERT INTO layout_items (label, ratio, owner, score, rank) VALUES ('blue', 61.28, 'edge', 5.03, 21);
INSERT INTO layout_items (label, ratio, owner, score, rank) VALUES ('blue', 50.8, 'primary', 0.7, 27);
INSERT INTO layout_items (label, ratio, owner, score, rank) VALUES ('primary', 96.37, 'local', 22.92, 19);
