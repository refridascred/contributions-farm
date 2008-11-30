-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    score REAL NOT NULL DEFAULT 0,
    label TEXT,
    level INTEGER,
    rank INTEGER,
    weight REAL
);

CREATE INDEX IF NOT EXISTS idx_layout_items_label ON layout_items (label);

INSERT INTO layout_items (score, label, level, rank, weight) VALUES (48.17, 'edge', 66, 6, 85.35);
INSERT INTO layout_items (score, label, level, rank, weight) VALUES (60.73, 'strict', 85, 57, 83.72);
