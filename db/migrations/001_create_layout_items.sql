-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    token TEXT,
    created_at TIMESTAMP,
    level INTEGER,
    rank INTEGER,
    active INTEGER NOT NULL DEFAULT 1
);

CREATE INDEX IF NOT EXISTS idx_layout_items_rank ON layout_items (rank);

INSERT INTO layout_items (token, level, rank, active) VALUES ('legacy', 16, 72, 70);
INSERT INTO layout_items (token, level, rank, active) VALUES ('legacy', 14, 39, 37);
INSERT INTO layout_items (token, level, rank, active) VALUES ('standard', 27, 24, 17);
