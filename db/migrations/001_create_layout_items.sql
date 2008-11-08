-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    label TEXT,
    active INTEGER NOT NULL DEFAULT 1,
    score REAL NOT NULL DEFAULT 0,
    count INTEGER NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_layout_items_label ON layout_items (label);

INSERT INTO layout_items (label, active, score, count) VALUES ('open', 26, 75.78, 26);
INSERT INTO layout_items (label, active, score, count) VALUES ('latest', 90, 97.14, 41);
INSERT INTO layout_items (label, active, score, count) VALUES ('standard', 4, 14.88, 13);
