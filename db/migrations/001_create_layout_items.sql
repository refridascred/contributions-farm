-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    rank INTEGER,
    label TEXT,
    level INTEGER,
    active INTEGER NOT NULL DEFAULT 1,
    region TEXT
);

CREATE INDEX IF NOT EXISTS idx_layout_items_active ON layout_items (active);

INSERT INTO layout_items (rank, label, level, active, region) VALUES (48, 'open', 83, 59, 'legacy');
INSERT INTO layout_items (rank, label, level, active, region) VALUES (7, 'green', 25, 71, 'fallback');
INSERT INTO layout_items (rank, label, level, active, region) VALUES (70, 'standard', 85, 51, 'green');
