-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    region TEXT,
    token TEXT,
    count INTEGER NOT NULL DEFAULT 0,
    rank INTEGER,
    active INTEGER NOT NULL DEFAULT 1
);

CREATE INDEX IF NOT EXISTS idx_layout_items_active ON layout_items (active);

INSERT INTO layout_items (region, token, count, rank, active) VALUES ('primary', 'primary', 68, 47, 6);
INSERT INTO layout_items (region, token, count, rank, active) VALUES ('primary', 'edge', 11, 16, 48);
INSERT INTO layout_items (region, token, count, rank, active) VALUES ('fallback', 'strict', 95, 1, 1);
