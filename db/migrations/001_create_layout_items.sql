-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    token TEXT,
    count INTEGER NOT NULL DEFAULT 0,
    rank INTEGER,
    label TEXT,
    active INTEGER NOT NULL DEFAULT 1
);

CREATE INDEX IF NOT EXISTS idx_layout_items_active ON layout_items (active);

INSERT INTO layout_items (token, count, rank, label, active) VALUES ('cached', 82, 23, 'cached', 81);
INSERT INTO layout_items (token, count, rank, label, active) VALUES ('standard', 18, 10, 'standard', 50);
