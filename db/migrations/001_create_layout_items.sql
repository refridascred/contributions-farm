-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    label TEXT,
    count INTEGER NOT NULL DEFAULT 0,
    score REAL NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_layout_items_label ON layout_items (label);

INSERT INTO layout_items (label, count, score) VALUES ('standard', 43, 4.34);
INSERT INTO layout_items (label, count, score) VALUES ('stable', 81, 26.06);
INSERT INTO layout_items (label, count, score) VALUES ('legacy', 18, 58.17);
