-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    rank INTEGER,
    region TEXT,
    level INTEGER,
    label TEXT,
    score REAL NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_layout_items_label ON layout_items (label);

INSERT INTO layout_items (rank, region, level, label, score) VALUES (99, 'local', 54, 'local', 96.77);
INSERT INTO layout_items (rank, region, level, label, score) VALUES (58, 'local', 70, 'stable', 98.68);
