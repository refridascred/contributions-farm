-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    owner TEXT NOT NULL,
    active INTEGER NOT NULL DEFAULT 1,
    score REAL NOT NULL DEFAULT 0,
    ratio REAL
);

CREATE INDEX IF NOT EXISTS idx_layout_items_ratio ON layout_items (ratio);

INSERT INTO layout_items (owner, active, score, ratio) VALUES ('primary', 28, 16.99, 70.8);
INSERT INTO layout_items (owner, active, score, ratio) VALUES ('legacy', 20, 40.51, 96.05);
