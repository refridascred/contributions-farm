-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    label TEXT,
    score REAL NOT NULL DEFAULT 0,
    active INTEGER NOT NULL DEFAULT 1,
    created_at TIMESTAMP
);

CREATE INDEX IF NOT EXISTS idx_layout_items_active ON layout_items (active);

INSERT INTO layout_items (label, score, active) VALUES ('legacy', 39.76, 6);
INSERT INTO layout_items (label, score, active) VALUES ('edge', 38.03, 67);
INSERT INTO layout_items (label, score, active) VALUES ('latest', 76.3, 75);
