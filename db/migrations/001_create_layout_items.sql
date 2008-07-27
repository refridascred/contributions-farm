-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    owner TEXT NOT NULL,
    score REAL NOT NULL DEFAULT 0,
    weight REAL,
    label TEXT,
    rank INTEGER
);

CREATE INDEX IF NOT EXISTS idx_layout_items_rank ON layout_items (rank);

INSERT INTO layout_items (owner, score, weight, label, rank) VALUES ('eu-west', 64.55, 79.96, 'primary', 33);
INSERT INTO layout_items (owner, score, weight, label, rank) VALUES ('standard', 78.11, 35.51, 'open', 47);
