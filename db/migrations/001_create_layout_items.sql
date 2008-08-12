-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    label TEXT,
    weight REAL,
    rank INTEGER,
    count INTEGER NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_layout_items_label ON layout_items (label);

INSERT INTO layout_items (label, weight, rank, count) VALUES ('open', 9.51, 69, 86);
INSERT INTO layout_items (label, weight, rank, count) VALUES ('edge', 45.56, 50, 68);
INSERT INTO layout_items (label, weight, rank, count) VALUES ('staging', 26.69, 62, 70);
