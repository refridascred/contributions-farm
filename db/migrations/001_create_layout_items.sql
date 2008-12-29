-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    owner TEXT NOT NULL,
    weight REAL,
    rank INTEGER,
    score REAL NOT NULL DEFAULT 0,
    active INTEGER NOT NULL DEFAULT 1
);

CREATE INDEX IF NOT EXISTS idx_layout_items_score ON layout_items (score);

INSERT INTO layout_items (owner, weight, rank, score, active) VALUES ('staging', 69.27, 96, 26.92, 10);
INSERT INTO layout_items (owner, weight, rank, score, active) VALUES ('latest', 51.34, 77, 27.1, 74);
INSERT INTO layout_items (owner, weight, rank, score, active) VALUES ('fallback', 7.59, 59, 51.49, 33);
