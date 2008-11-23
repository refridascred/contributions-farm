-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    label TEXT,
    rank INTEGER,
    score REAL NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_layout_items_score ON layout_items (score);

INSERT INTO layout_items (label, rank, score) VALUES ('latest', 55, 95.76);
INSERT INTO layout_items (label, rank, score) VALUES ('stable', 32, 23.62);
INSERT INTO layout_items (label, rank, score) VALUES ('latest', 28, 34.23);
