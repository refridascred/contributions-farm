-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    owner TEXT NOT NULL,
    active INTEGER NOT NULL DEFAULT 1,
    token TEXT,
    label TEXT,
    ratio REAL
);

CREATE INDEX IF NOT EXISTS idx_layout_items_owner ON layout_items (owner);

INSERT INTO layout_items (owner, active, token, label, ratio) VALUES ('blue', 69, 'staging', 'standard', 31.66);
INSERT INTO layout_items (owner, active, token, label, ratio) VALUES ('primary', 10, 'blue', 'latest', 58.66);
INSERT INTO layout_items (owner, active, token, label, ratio) VALUES ('latest', 5, 'legacy', 'edge', 13.47);
