-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    rank INTEGER,
    label TEXT,
    active INTEGER NOT NULL DEFAULT 1,
    level INTEGER,
    region TEXT
);

CREATE INDEX IF NOT EXISTS idx_layout_items_active ON layout_items (active);

INSERT INTO layout_items (rank, label, active, level, region) VALUES (66, 'latest', 77, 28, 'open');
INSERT INTO layout_items (rank, label, active, level, region) VALUES (36, 'local', 12, 35, 'staging');
INSERT INTO layout_items (rank, label, active, level, region) VALUES (50, 'legacy', 27, 46, 'strict');
