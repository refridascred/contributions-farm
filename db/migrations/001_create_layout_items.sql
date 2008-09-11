-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    rank INTEGER,
    token TEXT,
    count INTEGER NOT NULL DEFAULT 0,
    label TEXT,
    level INTEGER
);

CREATE INDEX IF NOT EXISTS idx_layout_items_rank ON layout_items (rank);

INSERT INTO layout_items (rank, token, count, label, level) VALUES (50, 'open', 37, 'legacy', 56);
INSERT INTO layout_items (rank, token, count, label, level) VALUES (44, 'local', 64, 'stable', 74);
INSERT INTO layout_items (rank, token, count, label, level) VALUES (56, 'edge', 31, 'standard', 79);
