-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    owner TEXT NOT NULL,
    score REAL NOT NULL DEFAULT 0,
    rank INTEGER,
    level INTEGER
);

CREATE INDEX IF NOT EXISTS idx_layout_items_score ON layout_items (score);

INSERT INTO layout_items (owner, score, rank, level) VALUES ('eu-west', 46.17, 60, 66);
INSERT INTO layout_items (owner, score, rank, level) VALUES ('strict', 90.66, 43, 6);
