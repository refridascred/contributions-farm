-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    count INTEGER NOT NULL DEFAULT 0,
    owner TEXT NOT NULL,
    score REAL NOT NULL DEFAULT 0,
    rank INTEGER
);

CREATE INDEX IF NOT EXISTS idx_layout_items_count ON layout_items (count);

INSERT INTO layout_items (count, owner, score, rank) VALUES (67, 'fallback', 91.52, 86);
INSERT INTO layout_items (count, owner, score, rank) VALUES (38, 'eu-west', 93.14, 15);
INSERT INTO layout_items (count, owner, score, rank) VALUES (75, 'standard', 46.44, 92);
