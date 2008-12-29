-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    label TEXT,
    score REAL NOT NULL DEFAULT 0,
    rank INTEGER
);

CREATE INDEX IF NOT EXISTS idx_layout_items_score ON layout_items (score);

INSERT INTO layout_items (label, score, rank) VALUES ('latest', 82.85, 35);
INSERT INTO layout_items (label, score, rank) VALUES ('primary', 32.86, 72);
