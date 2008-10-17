-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    region TEXT,
    created_at TIMESTAMP,
    score REAL NOT NULL DEFAULT 0,
    active INTEGER NOT NULL DEFAULT 1
);

CREATE INDEX IF NOT EXISTS idx_layout_items_active ON layout_items (active);

INSERT INTO layout_items (region, score, active) VALUES ('latest', 56.26, 18);
INSERT INTO layout_items (region, score, active) VALUES ('legacy', 19.49, 66);
INSERT INTO layout_items (region, score, active) VALUES ('primary', 24.97, 0);
