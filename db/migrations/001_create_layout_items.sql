-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    level INTEGER,
    label TEXT,
    rank INTEGER,
    active INTEGER NOT NULL DEFAULT 1,
    ratio REAL
);

CREATE INDEX IF NOT EXISTS idx_layout_items_rank ON layout_items (rank);

INSERT INTO layout_items (level, label, rank, active, ratio) VALUES (1, 'cached', 95, 7, 8.75);
INSERT INTO layout_items (level, label, rank, active, ratio) VALUES (5, 'latest', 95, 66, 3.62);
