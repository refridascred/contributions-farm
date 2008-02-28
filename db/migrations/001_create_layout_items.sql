-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    score REAL NOT NULL DEFAULT 0,
    rank INTEGER,
    ratio REAL,
    label TEXT
);

CREATE INDEX IF NOT EXISTS idx_layout_items_label ON layout_items (label);

INSERT INTO layout_items (score, rank, ratio, label) VALUES (0.58, 38, 48.6, 'stable');
INSERT INTO layout_items (score, rank, ratio, label) VALUES (90.4, 59, 23.32, 'edge');
INSERT INTO layout_items (score, rank, ratio, label) VALUES (80.85, 79, 68.76, 'green');
