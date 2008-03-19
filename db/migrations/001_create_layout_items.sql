-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    rank INTEGER,
    owner TEXT NOT NULL,
    label TEXT,
    count INTEGER NOT NULL DEFAULT 0,
    ratio REAL
);

CREATE INDEX IF NOT EXISTS idx_layout_items_count ON layout_items (count);

INSERT INTO layout_items (rank, owner, label, count, ratio) VALUES (91, 'green', 'fallback', 78, 55.19);
INSERT INTO layout_items (rank, owner, label, count, ratio) VALUES (17, 'standard', 'edge', 53, 19.65);
