-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    ratio REAL,
    score REAL NOT NULL DEFAULT 0,
    label TEXT,
    active INTEGER NOT NULL DEFAULT 1,
    rank INTEGER
);

CREATE INDEX IF NOT EXISTS idx_layout_items_label ON layout_items (label);

INSERT INTO layout_items (ratio, score, label, active, rank) VALUES (52.87, 8.14, 'standard', 55, 18);
INSERT INTO layout_items (ratio, score, label, active, rank) VALUES (63.26, 93.92, 'standard', 26, 10);
INSERT INTO layout_items (ratio, score, label, active, rank) VALUES (72.95, 38.16, 'cached', 28, 79);
