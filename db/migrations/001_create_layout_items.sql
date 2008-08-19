-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    label TEXT,
    score REAL NOT NULL DEFAULT 0,
    count INTEGER NOT NULL DEFAULT 0,
    active INTEGER NOT NULL DEFAULT 1
);

CREATE INDEX IF NOT EXISTS idx_layout_items_score ON layout_items (score);

INSERT INTO layout_items (label, score, count, active) VALUES ('cached', 90.57, 28, 85);
INSERT INTO layout_items (label, score, count, active) VALUES ('staging', 39.95, 2, 13);
INSERT INTO layout_items (label, score, count, active) VALUES ('stable', 13.28, 95, 91);
