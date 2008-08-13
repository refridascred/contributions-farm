-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    rank INTEGER,
    created_at TIMESTAMP,
    active INTEGER NOT NULL DEFAULT 1,
    region TEXT,
    level INTEGER
);

CREATE INDEX IF NOT EXISTS idx_layout_items_created_at ON layout_items (created_at);

INSERT INTO layout_items (rank, active, region, level) VALUES (17, 22, 'open', 82);
INSERT INTO layout_items (rank, active, region, level) VALUES (31, 48, 'legacy', 78);
INSERT INTO layout_items (rank, active, region, level) VALUES (76, 44, 'open', 16);
