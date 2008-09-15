-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    rank INTEGER,
    label TEXT,
    level INTEGER,
    created_at TIMESTAMP,
    active INTEGER NOT NULL DEFAULT 1
);

CREATE INDEX IF NOT EXISTS idx_layout_items_active ON layout_items (active);

INSERT INTO layout_items (rank, label, level, active) VALUES (16, 'fallback', 43, 53);
INSERT INTO layout_items (rank, label, level, active) VALUES (78, 'standard', 44, 29);
INSERT INTO layout_items (rank, label, level, active) VALUES (63, 'legacy', 95, 42);
