-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    count INTEGER NOT NULL DEFAULT 0,
    label TEXT,
    score REAL NOT NULL DEFAULT 0,
    ratio REAL,
    state TEXT NOT NULL DEFAULT 'new'
);

CREATE INDEX IF NOT EXISTS idx_layout_items_label ON layout_items (label);

INSERT INTO layout_items (count, label, score, ratio, state) VALUES (39, 'primary', 74.96, 82.55, 'green');
INSERT INTO layout_items (count, label, score, ratio, state) VALUES (25, 'eu-west', 24.78, 43.56, 'blue');
INSERT INTO layout_items (count, label, score, ratio, state) VALUES (44, 'stable', 81.49, 95.72, 'strict');
