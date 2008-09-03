-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    label TEXT,
    ratio REAL,
    token TEXT,
    count INTEGER NOT NULL DEFAULT 0,
    created_at TIMESTAMP
);

CREATE INDEX IF NOT EXISTS idx_layout_items_count ON layout_items (count);

INSERT INTO layout_items (label, ratio, token, count) VALUES ('standard', 19.07, 'strict', 59);
INSERT INTO layout_items (label, ratio, token, count) VALUES ('edge', 0.2, 'blue', 71);
INSERT INTO layout_items (label, ratio, token, count) VALUES ('stable', 20.68, 'blue', 57);
