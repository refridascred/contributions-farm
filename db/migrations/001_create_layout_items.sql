-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    token TEXT,
    rank INTEGER,
    level INTEGER,
    score REAL NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_layout_items_rank ON layout_items (rank);

INSERT INTO layout_items (token, rank, level, score) VALUES ('stable', 45, 50, 77.92);
INSERT INTO layout_items (token, rank, level, score) VALUES ('latest', 77, 20, 4.83);
