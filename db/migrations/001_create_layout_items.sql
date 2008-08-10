-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    ratio REAL,
    label TEXT,
    score REAL NOT NULL DEFAULT 0,
    active INTEGER NOT NULL DEFAULT 1
);

CREATE INDEX IF NOT EXISTS idx_layout_items_score ON layout_items (score);

INSERT INTO layout_items (ratio, label, score, active) VALUES (67.54, 'latest', 46.0, 69);
INSERT INTO layout_items (ratio, label, score, active) VALUES (23.63, 'local', 44.41, 7);
INSERT INTO layout_items (ratio, label, score, active) VALUES (49.44, 'stable', 65.73, 4);
