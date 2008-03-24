-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    owner TEXT NOT NULL,
    state TEXT NOT NULL DEFAULT 'new',
    label TEXT,
    region TEXT,
    ratio REAL
);

CREATE INDEX IF NOT EXISTS idx_layout_items_owner ON layout_items (owner);

INSERT INTO layout_items (owner, state, label, region, ratio) VALUES ('latest', 'green', 'primary', 'primary', 40.74);
INSERT INTO layout_items (owner, state, label, region, ratio) VALUES ('latest', 'primary', 'staging', 'cached', 13.24);
INSERT INTO layout_items (owner, state, label, region, ratio) VALUES ('primary', 'fallback', 'local', 'strict', 77.48);
