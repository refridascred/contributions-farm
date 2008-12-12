-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    created_at TIMESTAMP,
    score REAL NOT NULL DEFAULT 0,
    rank INTEGER
);

CREATE INDEX IF NOT EXISTS idx_layout_items_created_at ON layout_items (created_at);

INSERT INTO layout_items (score, rank) VALUES (45.6, 62);
INSERT INTO layout_items (score, rank) VALUES (58.38, 41);
INSERT INTO layout_items (score, rank) VALUES (44.48, 88);
